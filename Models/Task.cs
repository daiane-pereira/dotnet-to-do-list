using System;

namespace ToDoList.Models
{
    public class Task
    {
        public Task()
        {
            
        }
        public Task(int id, string name, double priority, DateTime deadline, int percentageCompleted)
        {
            this.id = id;
            this.name = name;
            this.priority = priority;
            this.deadline = deadline;
            this.percentageCompleted = percentageCompleted;

        }

        public int id { get; set; }
        
        public string name { get; set; }

        public double priority { get; set; }

        public DateTime deadline { get; set; }

        public int percentageCompleted { get; set; }
    }
}