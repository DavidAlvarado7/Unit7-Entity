using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace unit7_notes_entity.Models
{
	public class ToDo
	{

		[Key] //your primary key!!!
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto incrementing our ID

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsDont { get; set; }
		public ToDo()
		{

		}
	}
}

