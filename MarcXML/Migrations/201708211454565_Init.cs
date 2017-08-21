namespace MarcXML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MARC_XML$",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ID_Broj_Knjige = c.String(maxLength: 255),
                        XML = c.String(),
                        Datum_preuzimanja = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_Parsed_Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        leader = c.String(maxLength: 1000),
                        controlfield_003 = c.String(maxLength: 1000),
                        controlfield_005 = c.String(maxLength: 1000),
                        controlfield_008 = c.String(maxLength: 1000),
                        datafield_020_a = c.String(maxLength: 1000),
                        datafield_022_a = c.String(maxLength: 1000),
                        datafield_035_a = c.String(maxLength: 1000),
                        datafield_040_a = c.String(maxLength: 1000),
                        datafield_040_b = c.String(maxLength: 1000),
                        datafield_040_c = c.String(maxLength: 1000),
                        datafield_040_d = c.String(maxLength: 1000),
                        datafield_040_e = c.String(maxLength: 1000),
                        datafield_041_a = c.String(maxLength: 1000),
                        datafield_041_h = c.String(maxLength: 1000),
                        datafield_044_a = c.String(maxLength: 1000),
                        datafield_080_a = c.String(maxLength: 1000),
                        datafield_100_4 = c.String(maxLength: 1000),
                        datafield_100_a = c.String(maxLength: 1000),
                        datafield_110_a = c.String(maxLength: 1000),
                        datafield_110_c = c.String(maxLength: 1000),
                        datafield_245_a = c.String(maxLength: 1000),
                        datafield_245_b = c.String(maxLength: 1000),
                        datafield_245_c = c.String(maxLength: 1000),
                        datafield_245_n = c.String(maxLength: 1000),
                        datafield_245_p = c.String(maxLength: 1000),
                        datafield_260_a = c.String(maxLength: 1000),
                        datafield_260_b = c.String(maxLength: 1000),
                        datafield_260_c = c.String(maxLength: 1000),
                        datafield_300_a = c.String(maxLength: 1000),
                        datafield_300_b = c.String(maxLength: 1000),
                        datafield_300_c = c.String(maxLength: 1000),
                        datafield_310_a = c.String(maxLength: 1000),
                        datafield_362_a = c.String(maxLength: 1000),
                        datafield_440_a = c.String(maxLength: 1000),
                        datafield_440_v = c.String(maxLength: 1000),
                        datafield_490_a = c.String(maxLength: 1000),
                        datafield_490_v = c.String(maxLength: 1000),
                        datafield_500_a = c.String(maxLength: 1000),
                        datafield_504_a = c.String(maxLength: 1000),
                        datafield_505_a = c.String(maxLength: 1000),
                        datafield_520_a = c.String(maxLength: 1000),
                        datafield_546_a = c.String(maxLength: 1000),
                        datafield_550_a = c.String(maxLength: 1000),
                        datafield_555_a = c.String(maxLength: 1000),
                        datafield_653_a = c.String(maxLength: 1000),
                        datafield_700_4 = c.String(maxLength: 1000),
                        datafield_700_9 = c.String(maxLength: 1000),
                        datafield_700_a = c.String(maxLength: 1000),
                        datafield_740_a = c.String(maxLength: 1000),
                        datafield_776_t = c.String(maxLength: 1000),
                        datafield_776_x = c.String(maxLength: 1000),
                        datafield_780_t = c.String(maxLength: 1000),
                        datafield_780_x = c.String(maxLength: 1000),
                        datafield_830_a = c.String(maxLength: 1000),
                        datafield_830_n = c.String(maxLength: 1000),
                        datafield_830_p = c.String(maxLength: 1000),
                        datafield_830_v = c.String(maxLength: 1000),
                        datafield_856_u = c.String(maxLength: 1000),
                        datafield_856_z = c.String(maxLength: 1000),
                        datafield_942_6 = c.String(maxLength: 1000),
                        datafield_942_b = c.String(maxLength: 1000),
                        datafield_942_c = c.String(maxLength: 1000),
                        datafield_942_d = c.String(maxLength: 1000),
                        datafield_942_h = c.String(maxLength: 1000),
                        datafield_942_i = c.String(maxLength: 1000),
                        datafield_942_t = c.String(maxLength: 1000),
                        datafield_942_u = c.String(maxLength: 1000),
                        datafield_952_0 = c.String(maxLength: 1000),
                        datafield_952_1 = c.String(maxLength: 1000),
                        datafield_952_4 = c.String(maxLength: 1000),
                        datafield_952_6 = c.String(maxLength: 1000),
                        datafield_952_7 = c.String(maxLength: 1000),
                        datafield_952_8 = c.String(maxLength: 1000),
                        datafield_952_9 = c.String(maxLength: 1000),
                        datafield_952_a = c.String(maxLength: 1000),
                        datafield_952_b = c.String(maxLength: 1000),
                        datafield_952_c = c.String(maxLength: 1000),
                        datafield_952_d = c.String(maxLength: 1000),
                        datafield_952_e = c.String(maxLength: 1000),
                        datafield_952_g = c.String(maxLength: 1000),
                        datafield_952_h = c.String(maxLength: 1000),
                        datafield_952_i = c.String(maxLength: 1000),
                        datafield_952_l = c.String(maxLength: 1000),
                        datafield_952_m = c.String(maxLength: 1000),
                        datafield_952_o = c.String(maxLength: 1000),
                        datafield_952_p = c.String(maxLength: 1000),
                        datafield_952_q = c.String(maxLength: 1000),
                        datafield_952_r = c.String(maxLength: 1000),
                        datafield_952_s = c.String(maxLength: 1000),
                        datafield_952_t = c.String(maxLength: 1000),
                        datafield_952_v = c.String(maxLength: 1000),
                        datafield_952_w = c.String(maxLength: 1000),
                        datafield_952_y = c.String(maxLength: 1000),
                        datafield_952_z = c.String(maxLength: 1000),
                        datafield_991_a = c.String(maxLength: 1000),
                        datafield_992_a = c.String(maxLength: 1000),
                        datafield_992_b = c.String(maxLength: 1000),
                        datafield_992_c = c.String(maxLength: 1000),
                        datafield_992_d = c.String(maxLength: 1000),
                        datafield_992_e = c.String(maxLength: 1000),
                        datafield_999_c = c.String(maxLength: 1000),
                        datafield_999_d = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Parsed_Data");
            DropTable("dbo.MARC_XML$");
        }
    }
}
