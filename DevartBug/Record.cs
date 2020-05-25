using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevartBug
{
    [Table("records")]
    public class Record
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("int_column1")]
        public int? Int1 { get; set; }

        [Column("int_column2")]
        public int? Int2 { get; set; }

        [Column("date_column")]
        public DateTime Date { get; set; }

        [Column("boolean_column")]
        public bool Bool { get; set; }

        [Column("enum_int_column")]
        public SomeEnum? EnumValue { get; set; }
    }
}
