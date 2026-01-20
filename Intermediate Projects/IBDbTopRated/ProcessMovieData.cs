using StringManipulate.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using System.Text;
namespace StringManipulate
{
    public class ProcessMovieData : CodedWorkflow
    {
        [Workflow]
        public string Execute(DataTable movieTable)
        {
           
            var sb = new StringBuilder();

        
             var bestMovie = movieTable.AsEnumerable()
            .OrderByDescending(row => Convert.ToInt32(row["date"]));
            
              foreach (System.Data.DataRow row in bestMovie)
            {
           
                
                string title = row["title"]?.ToString()?.Trim() ?? "N/A";
                string date = row["date"]?.ToString()?.Trim() ?? "N/A";
                string rate = row["rate"]?.ToString()?.Trim() ?? "N/A";
                string duration = row["duration"]?.ToString()?.Trim() ?? "N/A";

                sb.AppendLine($"🎬 Movie #{title}");
                sb.AppendLine("-----------------------");
                sb.AppendLine($"Date    : {date}");
                sb.AppendLine($"Rate    : {rate}");
                sb.AppendLine($"Duration: {duration}");
                sb.AppendLine($"The Film Was Released: {2025 - Convert.ToInt32(row["date"])} Years ago");
                sb.AppendLine("=======================");
                sb.AppendLine();
            }

            return sb.ToString().Trim();
        
            
        }
    }
}