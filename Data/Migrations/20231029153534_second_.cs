using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    public partial class second_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "id", "priority_level", "priority_name" },
                values: new object[,]
                {
                    { 1, 1, "Lowest" },
                    { 2, 2, "Low" },
                    { 3, 3, "Medium" },
                    { 4, 4, "High" },
                    { 5, 5, "Highest" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "id", "PriorityId", "due_date", "task_description", "task_id", "task_name", "task_staus" },
                values: new object[] { 1, 1, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Cook Dinner for everyone at home", 1, "Cook", false });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "id", "PriorityId", "due_date", "task_description", "task_id", "task_name", "task_staus" },
                values: new object[] { 2, 1, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Wash the Plates before going to bed", 2, "Clean the Dishes", false });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "id", "PriorityId", "due_date", "task_description", "task_id", "task_name", "task_staus" },
                values: new object[] { 3, 2, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Get the essential Groceries on the Grocery List", 3, "Grocery Shoping", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
