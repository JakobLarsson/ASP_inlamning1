using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_inlamning1.Migrations
{
    public partial class TEST2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attendeEvent");

            migrationBuilder.CreateTable(
                name: "AttendeeEvent",
                columns: table => new
                {
                    AttendeeID = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeEvent", x => new { x.AttendeeID, x.EventID });
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_EventID",
                table: "AttendeeEvent",
                column: "EventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendeeEvent");

            migrationBuilder.CreateTable(
                name: "attendeEvent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendeeID = table.Column<int>(type: "int", nullable: true),
                    EventID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendeEvent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_attendeEvent_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attendeEvent_Events_EventID1",
                        column: x => x.EventID1,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendeEvent_AttendeeID",
                table: "attendeEvent",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_attendeEvent_EventID1",
                table: "attendeEvent",
                column: "EventID1");
        }
    }
}
