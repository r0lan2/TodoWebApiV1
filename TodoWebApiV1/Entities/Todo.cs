using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TodoWebApiV1.Entities
{
    public class Todo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public bool Complete { get; set; }

    }

    public class TodoMap:EntityTypeConfiguration<Todo>
    {
        public TodoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Todos");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Complete).HasColumnName("Complete");
        }
    }




}