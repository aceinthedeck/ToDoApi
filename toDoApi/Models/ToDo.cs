using System;
using toDoApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
namespace toDoApi.Models
{
	public class ToDo
	{
		public int Id { get; set; }
		public string Title { get; set; }
	}
}

