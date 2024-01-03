using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_task.Shared.Shared
{
    public class StudentService
    {

            private readonly HttpClient _httpClient;

            public StudentService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task AddStudentAsync(Course student)
            {
                await _httpClient.PostAsJsonAsync("api/Student", student);
            }

            public async Task<List<Course>> GetStudentsBelow50Async()
            {
                return await _httpClient.GetFromJsonAsync<List<Course>>("api/Student/below50");
            }

            public async Task<List<Course>> GetStudentsBetween50And85Async()
            {
                return await _httpClient.GetFromJsonAsync<List<Course>>("api/Student/between50and85");
            }

            public async Task<List<Course>> GetStudentsAbove85Async()
            {
                return await _httpClient.GetFromJsonAsync<List<Course>>("api/Student/above85");
            }
        }

    }

