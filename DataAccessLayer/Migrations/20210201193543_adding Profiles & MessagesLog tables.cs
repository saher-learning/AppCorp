using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addingProfilesMessagesLogtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessagesLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    MessageSent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "1686041828299", "Chaim" },
                    { 73, "1619051777299", "Noelle" },
                    { 72, "1699101676899", "Camilla" },
                    { 71, "1668070850699", "John" },
                    { 70, "1610092928999", "Joy" },
                    { 69, "1657012088699", "Winifred" },
                    { 68, "1661061743199", "Jonas" },
                    { 67, "1640060663599", "Shelly" },
                    { 66, "1683072514299", "Herman" },
                    { 65, "1616070115199", "Flynn" },
                    { 64, "1613061721499", "Kevin" },
                    { 63, "1657082432799", "Wayne" },
                    { 62, "1608040837199", "Jana" },
                    { 61, "1647110243299", "Samson" },
                    { 60, "1613080278199", "Yvonne" },
                    { 59, "1621012650499", "Idona" },
                    { 58, "1618031459799", "Geraldine" },
                    { 57, "1698113007699", "Warren" },
                    { 56, "1671031022599", "Ignatius" },
                    { 55, "1602071238099", "Hector" },
                    { 54, "1633080375199", "Murphy" },
                    { 53, "1631081785199", "Fletcher" },
                    { 74, "1672112935399", "Hollee" },
                    { 52, "1664121873899", "Amity" },
                    { 75, "1632011952199", "Damon" },
                    { 77, "1684031765599", "Daphne" },
                    { 98, "1690102573499", "Baxter" },
                    { 97, "1660060458099", "Aretha" },
                    { 96, "1692041401399", "Jenna" },
                    { 95, "1607072647999", "Plato" },
                    { 94, "1613071180499", "Baxter" },
                    { 93, "1663072384399", "Daryl" },
                    { 92, "1692102894899", "Orlando" },
                    { 91, "1668060125399", "Susan" },
                    { 90, "1636031208099", "Robert" },
                    { 89, "1649070570699", "Jonah" },
                    { 88, "1650101035099", "Daquan" },
                    { 87, "1692093071399", "Tasha" },
                    { 86, "1661112063799", "Angela" },
                    { 85, "1690082616299", "Leslie" },
                    { 84, "1609112130399", "Nissim" },
                    { 83, "1656080825499", "Derek" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 82, "1618011374699", "Azalia" },
                    { 81, "1671081752999", "Ali" },
                    { 80, "1623040468499", "Tarik" },
                    { 79, "1643031564199", "Tanisha" },
                    { 78, "1644022564499", "Priscilla" },
                    { 76, "1684012416199", "Axel" },
                    { 51, "1600090313499", "Francis" },
                    { 50, "1609030736099", "Ivana" },
                    { 49, "1638121187699", "Odette" },
                    { 22, "1640092078999", "Noel" },
                    { 21, "1646042511299", "Xavier" },
                    { 20, "1655011943599", "Beau" },
                    { 19, "1678070360199", "Philip" },
                    { 18, "1690021888699", "Rosalyn" },
                    { 17, "1698120710899", "Xerxes" },
                    { 16, "1643031884399", "Kylee" },
                    { 15, "1688090345099", "Briar" },
                    { 14, "1628060984499", "Hedwig" },
                    { 13, "1618021320899", "Amber" },
                    { 12, "1633090464799", "Noel" },
                    { 11, "1689040276999", "Felicia" },
                    { 10, "1694013052899", "Darius" },
                    { 9, "1626022029399", "Ulric" },
                    { 8, "1631112326699", "Casey" },
                    { 7, "1675042471999", "Rhona" },
                    { 6, "1683092404299", "Yen" },
                    { 5, "1640010419899", "Ezekiel" },
                    { 4, "1683040258999", "Eve" },
                    { 3, "1620110657599", "Melinda" },
                    { 2, "1621042619399", "Tatum" },
                    { 23, "1666092029499", "Charity" },
                    { 24, "1656082580499", "Rajah" },
                    { 25, "1660072305099", "Yen" },
                    { 26, "1682112931599", "Benedict" },
                    { 48, "1633052726899", "Unity" },
                    { 47, "1680012484699", "Maya" },
                    { 46, "1682052202099", "Daniel" },
                    { 45, "1615021666899", "Yael" },
                    { 44, "1694022010199", "Merritt" },
                    { 43, "1671042978499", "Patricia" },
                    { 42, "1648061757099", "Rina" },
                    { 41, "1663060563299", "Hedy" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 40, "1653102220299", "Wynter" },
                    { 39, "1677080330899", "Harriet" },
                    { 99, "1611121721399", "Scarlett" },
                    { 38, "1621010512399", "Aimee" },
                    { 36, "1656101467799", "Fiona" },
                    { 35, "1655030180799", "Ishmael" },
                    { 34, "1687051911799", "Renee" },
                    { 33, "1699081251099", "Georgia" },
                    { 32, "1656022704199", "Cora" },
                    { 31, "1629060595999", "Camden" },
                    { 30, "1648110402799", "Burke" },
                    { 29, "1688082441099", "Curran" },
                    { 28, "1628043095099", "Meghan" },
                    { 27, "1610062842199", "Paul" },
                    { 37, "1639011847399", "Elvis" },
                    { 100, "1614120347999", "Althea" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessagesLog");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
