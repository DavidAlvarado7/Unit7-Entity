using System;
using Microsoft.EntityFrameworkCore;
using unit7_notes_entity.Models;

namespace unit7_notes_entity.Services
{
	public class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options) :base(options)
		{

			
		}

		public DbSet<ToDo> ToDos { get; set; }

	}
}

