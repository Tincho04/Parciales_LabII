using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test de archivos XML, Lectura y Escritura
        /// </summary>
        #region Test Archivos XML
        [TestMethod]
        public void ValidaGuardadoXML()
        {
            //Arrange: Genera un nuevo Turno de formato XML para probar el guardado de estos datos 
            TurnoXML turnoXml = new TurnoXML("SubjectTest_XML", "1");
            //Act: Efectua el método de guardado para archivo XML. Assert: Comprueba que el guardado de datos haya sido exitoso.
            Assert.IsTrue(TurnoXML.GuardaTestXML(turnoXml));
        }
        [TestMethod]
        public void ValidaLecturaTurnoXML()
        {
            //Arrange: Se encarga de declarar el nuevo turno derivado
            TurnoXML turnoDerivado = new TurnoXML();
            //Act: Ejecuta el método de lectura al archivo XML, cargando el ultimo turno 
            turnoDerivado = TurnoXML.Leer();
            //Assert valida que el turno se haya cargado exitosamente.
            Assert.IsNotNull(turnoDerivado);
        }
        #endregion

        /// <summary>
        /// Test de archivos Binarios, Lectura y Escritura
        /// </summary>
        #region Test Archivos Binarios
        [TestMethod]
        public void ValidaGuardadoBinario()
        {
            //Arrange: Genera un nuevo Turno de formato Binario para probar el guardado de estos datos 
            TurnoXML turnoXml = new TurnoXML("SubjectTest_BIN", "1");
            //Act: Efectua el método de guardado para archivo Binario. Assert: Comprueba que el guardado de datos haya sido exitoso.
            Assert.IsTrue(TurnoXML.GuardarBinario(turnoXml));
        }
        [TestMethod]
        public void ValidaLecturaPacienteBinario()
        {
            //Arrange: Se encarga de declarar un nuevo turno 
            TurnoXML turnoDerivado = new TurnoXML();
            //Act: Ejecuta el método de lectura al archivo XML, cargando el último turno
            turnoDerivado = TurnoXML.LeerBin();
            //Assert valida que el turno se haya cargado exitosamente
            Assert.IsNotNull(turnoDerivado);
        }
        #endregion

        /// <summary>
        /// Test de archivo Texto, Lectura y Escritura
        /// </summary>
        #region Test Archivo Texto
        [TestMethod]
        public void ValidaGuardadoTxt()
        {
            //Arrange: Genera un nuevo texto para probar el guardado de estos datos 
            Texto texto = new Texto();
            string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\TesteoLog.txt";
            //Act: Efectua el método de guardado para archivo de Texto. Assert: Comprueba que el guardado de datos haya sido exitoso.
            Assert.IsTrue(texto.Guardar(route, "Subject_Test_Message"));
        }
        [TestMethod]
        public void ValidaLecturaTxt()
        {
            //Arrange: Se encarga de declarar la Lista de pacientes derivados 
            Texto texto = new Texto();
            string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\TesteoLog.txt";
            //Act: Ejecuta el método de lectura al archivo de texto, cargando el log de errores, Assert: Valida que el método de lectura haya resultado exitoso.
            Assert.IsTrue(texto.Leer(route, out string logPrue));
        }
        #endregion

        /// <summary>
        /// Test para alta de turnos tanto derivados como internos
        /// </summary>
        #region Test de Altas
        [TestMethod]
        public void ValidaAltaTurnoDerivado()
        {
            //Arrange: Se declaran dos tipos de turnos, pacientes internos de la clinica y pacientes derivados de otra clínica.
            Turnos turnoDerivado = new Turnos("SubjectTest", "Extern_Patient", "SubjectTest", "Extern_Especialist", "Psicologo", false, 2, 1);
            List<Turnos> ListaTurnos = new List<Turnos>();
            //Act: Efectua el método de almacenar los turnos a la clínica. Assert: Se valida el alta exitoso de los turnos.
            Assert.IsTrue(Clinica.SumoTurno(ListaTurnos, turnoDerivado));
        }

        [TestMethod]
        public void ValidaAltaTurnoInterno()
        {
            //Arrange: Se declaran dos tipos de turnos, pacientes internos de la clinica y pacientes derivados de otra clínica.
            Turnos turnoInterno = new Turnos("SubjectTest", "Intern_Patient", "SubjectTest", "Intern_Especialist", "Clinica General", true, 1, 2);
            List<Turnos> ListaTurnos = new List<Turnos>();
            //Act: Efectua el método de almacenar los turnos a la clínica. Assert: Se valida el alta exitoso de los turnos.
            Assert.IsTrue(Clinica.SumoTurno(ListaTurnos, turnoInterno));
        }
        #endregion
    }
}
