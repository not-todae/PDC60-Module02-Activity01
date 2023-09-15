using System;
using System.Collections.Generic;
using System.Text;
using App1.Model;
namespace App1.ViewModel
{
    class TaskViewModel
    {
        public TaskModel TaskModelSet { get; set; }
        public TaskViewModel()
        {
            TaskModelSet = new TaskModel
            {
                Subjectcode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }

    }
}
