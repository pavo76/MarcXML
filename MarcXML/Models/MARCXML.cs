namespace MarcXML.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MARCXML : DbContext
    {
        public MARCXML()
            : base("name=MARCXML_DB")
        {
        }

        public virtual DbSet<MARC_XML_Data> MARC_XML_ { get; set; }
        public virtual DbSet<tbl_Parsed_Data> tbl_Parsed_Data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
