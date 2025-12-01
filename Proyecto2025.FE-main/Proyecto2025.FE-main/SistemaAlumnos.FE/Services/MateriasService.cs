using SistemaAlumnos.FE.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemaAlumnos.FE.Services
{
    public class MateriaService   // 👈 singular para consistencia
    {
        private readonly HttpClient _http;

        public MateriaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Materia>> ObtenerMateriasAsync()
        {
            var response = await _http.GetAsync("api/materias"); // 👈 plural
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Materia>>();
        }

        public async Task<bool> AgregarMateriaAsync(Materia materia)
        {
            var response = await _http.PostAsJsonAsync("api/materias", materia);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarMateriaAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/materias/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}