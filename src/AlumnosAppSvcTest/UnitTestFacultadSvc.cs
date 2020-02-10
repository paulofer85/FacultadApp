using System;
using System.Threading.Tasks;
using FacultadAppSvc.ContextTest;
using Microsoft.AspNetCore.Mvc;
using FacultadAppSvc.Models;
using Xunit;
using FacultadAppSvc.Controllers;


namespace FacultadAppSvc.Tests
{
    public class Tests
    {
        [Fact]
        public async Task IsGetAlumnosOk()
        {
            // Arrange
            var dbContext = DbContextMocker.GetAlumnosDbContext("AlumnoApp");
            var controller = new AlumnosController(dbContext);

            // Act
            var response = await controller.GetAlumnos(1);
            var value = (ObjectResult)response;

            dbContext.Dispose();

            // Assert
            Assert.True(value.StatusCode.Value == 200);
        }

        [Fact]
        public async Task IsCrearAlumnoOk()
        {
            // Arrange
            var dbContext = DbContextMocker.GetAlumnosDbContext("AlumnoApp");
            var controller = new AlumnosController(dbContext);

            // Act
            AlumnosParameters al = new AlumnosParameters();
            al.apellido = "Gardel";
            al.nombre = "Carlos";
            al.padron = "88888";
            al.domicilio = "Av. Siempre Viva 123";
            al.carreraId = 1;

            var response = await controller.PostAlumnos(al);
            var value = (ObjectResult)response;

            dbContext.Dispose();

            // Assert
            Assert.True(value.StatusCode.Value == 201);
        }
    }
}