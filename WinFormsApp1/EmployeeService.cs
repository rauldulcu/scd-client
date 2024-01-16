using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class EmployeeService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync("api/employee").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;

            }
            return null;
        }

        public List<Employee> GetEmployeesByDepartmentId(long departmentId)
        {
            List<Employee> employees = null;
            string apiUrl = $"api/employee/department/{departmentId}";
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;

            }
            return null;
        }

        public List<Employee> GetManagersByDepartmentId(long departmentId)
        {
            List<Employee> employees = null;
            string apiUrl = $"api/employee/department/{departmentId}/managers";
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;

            }
            return null;
        }
    }
}
