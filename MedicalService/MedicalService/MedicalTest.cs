using MedicalService.NewFolder;
using MedicalService.Page;
using NUnit.Framework;

namespace MedicalService
{
    public class Tests
    {
        LoginPage loginPage;
        MedicalPage medicalPage;
        
        [SetUp]
        public void SetUp()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            medicalPage = new MedicalPage();
        }
        
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        
        [Test]
        public void TC01_MakeAppointment_ShouldAppointmentBeCompleted()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("John Doe", "ThisIsNotPassword");
            //medicalPage.SelectOption("Hongkong CURA Healthcare Center");
            medicalPage.Facility.SendKeys("Hongkong CURA Healthcare Center");
            medicalPage.ChechBox.Click();
            medicalPage.MedicId.Click();
            medicalPage.VisitDate.SendKeys("25/12/2022");
            medicalPage.Comment.SendKeys("Zakazano");
            medicalPage.ButtonApp.Submit();

            Assert.That("Appointment Confirmation", Is.EqualTo(medicalPage.Confire.Text));


           
        }
    }
}