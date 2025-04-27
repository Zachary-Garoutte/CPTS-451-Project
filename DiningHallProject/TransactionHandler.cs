using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningHallProject
{
    internal class TransactionHandler
    {
        public void transaction(int hallID, int studentID, double totalPrice, string paymentMethod, DateTime dot)
        {

            using (var connection = new SqlConnection("Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                string query1 = "INSERT INTO dbo.transactionHistory (TransID, studentID, amount, paymentMethod, dining_hall_id, dot)" +
                            "VALUES(@TransID, @StudentID, @Amount, @PaymentMethod, @HallID, @DOT)";

                string query2 = "UPDATE dbo.Student SET balance = @Balance WHERE user_id = @UserID;";

                string query3 = "SELECT max(TransID) from dbo.transactionHistory;";

                string query4 = "SELECT balance FROM Student WHERE user_id = @UserID;";

                try
                {
                    int newTransactionID;
                    double currentBalance;

                    // 1. Get current balance
                    using (var getBalanceCommand = new SqlCommand(query4, connection, transaction))
                    {
                        getBalanceCommand.Parameters.AddWithValue("@UserID", studentID);
                        var result = getBalanceCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentBalance = Convert.ToDouble(result);
                        }
                        else
                        {
                            throw new Exception("Student not found!");
                        }
                    }

                    // 2. Check if balance is enough
                    if (currentBalance + totalPrice > 0)
                    {
                        // 3. Get new Transaction ID
                        using (var getMaxIDCommand = new SqlCommand(query3, connection, transaction))
                        {
                            var result = getMaxIDCommand.ExecuteScalar();
                            newTransactionID = Convert.ToInt32(result) + 1;
                        }

                        // 4. Insert into TransactionHistory
                        using (var insertTransactionCommand = new SqlCommand(query1, connection, transaction))
                        {
                            insertTransactionCommand.Parameters.AddWithValue("@TransID", newTransactionID);
                            insertTransactionCommand.Parameters.AddWithValue("@StudentID", studentID);
                            insertTransactionCommand.Parameters.AddWithValue("@Amount", totalPrice);
                            insertTransactionCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            if (hallID != 0)
                            {
                                insertTransactionCommand.Parameters.AddWithValue("@HallID", hallID);
                            }
                            else
                            {
                                insertTransactionCommand.Parameters.AddWithValue("HallID", DBNull.Value);
                            }
                            insertTransactionCommand.Parameters.AddWithValue("@DOT", dot);
                            insertTransactionCommand.ExecuteNonQuery();
                        }

                        // 5. Update balance
                        double newBalance = currentBalance + totalPrice;

                        using (var updateBalanceCommand = new SqlCommand(query2, connection, transaction))
                        {
                            updateBalanceCommand.Parameters.AddWithValue("@Balance", newBalance);
                            updateBalanceCommand.Parameters.AddWithValue("@UserID", studentID);
                            updateBalanceCommand.ExecuteNonQuery();
                        }

                        // 6. Commit if all succeeded
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                        throw new InvalidOperationException("Declined: Insufficient Funds!");
                    }
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

        }

    }
}
