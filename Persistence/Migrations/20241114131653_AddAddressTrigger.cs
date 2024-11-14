using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationFormApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressTrigger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create trigger to update the user count in GovernateUserCounts when an address is inserted or updated
            migrationBuilder.Sql(@"
                CREATE TRIGGER trg_UpdateGovernateUserCount
                ON Addresses
                AFTER INSERT, UPDATE
                AS
                BEGIN
                    SET NOCOUNT ON;

                    -- Insert or update the user count for the specific Governate
                    MERGE INTO GovernateUserCounts AS target
                    USING (SELECT GovernateID FROM Inserted) AS source
                    ON target.GovernateID = source.GovernateID
                    WHEN MATCHED THEN
                        UPDATE SET UserCount = (SELECT COUNT(*) FROM Addresses WHERE GovernateID = source.GovernateID)
                    WHEN NOT MATCHED THEN
                        INSERT (GovernateID, UserCount)
                        VALUES (source.GovernateID, (SELECT COUNT(*) FROM Addresses WHERE GovernateID = source.GovernateID));
                END
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the trigger when rolling back the migration
            migrationBuilder.Sql(@"
                DROP TRIGGER IF EXISTS trg_UpdateGovernateUserCount
            ");
        }
    }
}
