using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace VaquitApp.Test
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;
        private string path = @"C:\Test\apk\com.companyname.VaquitApp.apk";

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp.Android.ApkFile(path).StartApp();
        }

        [Test]
        public void VerificarTotal()
        {
            app.EnterText("nombre", "Gonza");
            app.EnterText("aporte", "250");
            app.Tap(c => c.Button("btnAgregar"));

            app.EnterText("nombre", "Pepe");
            app.EnterText("aporte", "50");
            app.Tap(c => c.Button("btnAgregar"));

            app.EnterText("nombre", "Pedro");
            app.EnterText("aporte", "300");
            app.Tap(c => c.Button("btnAgregar"));

            app.Tap("btnCalcular");

            AppResult result = app.Query(c => c.Marked("total")).FirstOrDefault();
            Assert.AreEqual(result.Text, "600", string.Format("El total debe ser 600 y es {0}",result.Text));
        }
        
    }
}

