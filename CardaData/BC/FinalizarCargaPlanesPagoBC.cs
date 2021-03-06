﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CardaData.BC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FinalizarCargaPlanesPagoBC recording.
    /// </summary>
    [TestModule("49cb08ef-929e-4a3c-96df-eaa3f3148d96", ModuleType.Recording, 1)]
    public partial class FinalizarCargaPlanesPagoBC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static FinalizarCargaPlanesPagoBC instance = new FinalizarCargaPlanesPagoBC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FinalizarCargaPlanesPagoBC()
        {
            NombreArchivo = "BCPlanDataLoader.xls";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FinalizarCargaPlanesPagoBC Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("8bb4d90e-0931-42e5-a69e-df43fdd1058a")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NombreArchivo.
        /// </summary>
        [TestVariable("6afbba72-5bce-41a7-be69-d1bcb1640c27")]
        public string NombreArchivo
        {
            get { return repo.NombreArchivo; }
            set { repo.NombreArchivo = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Examinar2' at Center.", repo.ApplicationUnderTest.Btn_Examinar2Info, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.Btn_Examinar2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'Ventana_Emergente_Abrir'", repo.Ventana_Emergente_Abrir.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(1));
            //repo.Ventana_Emergente_Abrir.SelfInfo.WaitForExists(5000);
            
            // Ventana Emergente
            //Report.Log(ReportLevel.Info, "Section", "Ventana Emergente", new RecordItemIndex(2));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VentanaEmergente_Examinar.Escritorio' at Center.", repo.VentanaEmergente_Examinar.EscritorioInfo, new RecordItemIndex(3));
            //repo.VentanaEmergente_Examinar.Escritorio.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\Carga_Inicial_QA\\BC'.", new RecordItemIndex(4));
            //Keyboard.Press("C:\\Carga_Inicial_QA\\BC");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            //Keyboard.Press("{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VentanaEmergente_Examinar.BarraInferior' at Center.", repo.VentanaEmergente_Examinar.BarraInferiorInfo, new RecordItemIndex(6));
            //repo.VentanaEmergente_Examinar.BarraInferior.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NombreArchivo'.", new RecordItemIndex(7));
            //Keyboard.Press(NombreArchivo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ventana_Emergente_Abrir.ButtonAbrir' at 47;13.", repo.Ventana_Emergente_Abrir.ButtonAbrirInfo, new RecordItemIndex(9));
            //repo.Ventana_Emergente_Abrir.ButtonAbrir.Click("47;13");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ApplicationUnderTest.CargandoArchivoS'", repo.ApplicationUnderTest.CargandoArchivoSInfo, new ActionTimeout(5000), new RecordItemIndex(11));
            //repo.ApplicationUnderTest.CargandoArchivoSInfo.WaitForExists(5000);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 3m for the attribute 'Value' to contain the specified value $NombreArchivo. Associated repository item: 'ApplicationUnderTest.txt_ArchivoCargado_qa2'", repo.ApplicationUnderTest.txt_ArchivoCargado_qa2Info, new RecordItemIndex(12));
            //repo.ApplicationUnderTest.txt_ArchivoCargado_qa2Info.WaitForAttributeContains(180000, "Value", NombreArchivo);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'ApplicationUnderTest.lbl_100Percent'", repo.ApplicationUnderTest.lbl_100PercentInfo, new ActionTimeout(120000), new RecordItemIndex(13));
            //repo.ApplicationUnderTest.lbl_100PercentInfo.WaitForExists(120000);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to not exist. Associated repository item: 'ApplicationUnderTest.DivTag100Percent'", repo.ApplicationUnderTest.DivTag100PercentInfo, new ActionTimeout(40000), new RecordItemIndex(14));
            //repo.ApplicationUnderTest.DivTag100PercentInfo.WaitForNotExists(40000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(15));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Btn_SiguientePlanesPago' at Center.", repo.ApplicationUnderTest.Btn_SiguientePlanesPagoInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.Btn_SiguientePlanesPago.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_SiguientePlanesPago' at Center.", repo.ApplicationUnderTest.Btn_SiguientePlanesPagoInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.Btn_SiguientePlanesPago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'ApplicationUnderTest.Copy_of_lbl_ReviewPlanDataUpload'", repo.ApplicationUnderTest.Copy_of_lbl_ReviewPlanDataUploadInfo, new ActionTimeout(60000), new RecordItemIndex(18));
            repo.ApplicationUnderTest.Copy_of_lbl_ReviewPlanDataUploadInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Finalizar__PlanesPago' at Center.", repo.ApplicationUnderTest.Btn_Finalizar__PlanesPagoInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Btn_Finalizar__PlanesPago.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 2m to exist. Associated repository item: 'ContinueOnFail.lblResultadoCargaPlanesPago_COF'", repo.ContinueOnFail.lblResultadoCargaPlanesPago_COFInfo, new ActionTimeout(120000), new RecordItemIndex(20));
                repo.ContinueOnFail.lblResultadoCargaPlanesPago_COFInfo.WaitForExists(120000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
