using AspTest01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTest01.DateContext
{

    /// <summary>
    ///  EntityFramework 이용하여 Context 생성
    /// </summary>
    public class AspNetNoteDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        ///DB를 연결하는 Connection. 


        //DB contect에 원래 존재하는 내용 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-378OLOA\MSSQLSERVER01;Database=AspNetNote;User Id = bonggu;Password = 201017;");
            //Migration 작업 시, EntityFramework.Core.Tool 패키지 필요 
            //Package Manager Console = add-migration FirstMigration 
            //
            //
            // Create Database = update-database
            //

        }


    }
}
