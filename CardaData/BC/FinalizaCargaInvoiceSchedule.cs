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
    ///The FinalizaCargaInvoiceSchedule recording.
    /// </summary>
    [TestModule("aafda17e-04a6-4ce2-b519-17beb2cf6714", ModuleType.Recording, 1)]
    public partial class FinalizaCargaInvoiceSchedule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static FinalizaCargaInvoiceSchedule instance = new FinalizaCargaInvoiceSchedule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FinalizaCargaInvoiceSchedule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FinalizaCargaInvoiceSchedule Instance
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
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ''.", new RecordItemIndex(7));
            //Keyboard.Press("");
            //Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ventana_Emergente_Abrir.ButtonAbrir' at 47;13.", repo.Ventana_Emergente_Abrir.ButtonAbrirInfo, new RecordItemIndex(9));
            //repo.Ventana_Emergente_Abrir.ButtonAbrir.Click("47;13");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'ApplicationUnderTest.lbl_100Percent'", repo.ApplicationUnderTest.lbl_100PercentInfo, new ActionTimeout(120000), new RecordItemIndex(11));
            //repo.ApplicationUnderTest.lbl_100PercentInfo.WaitForExists(120000);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_SubirArchivoExcel'", repo.ApplicationUnderTest.lbl_SubirArchivoExcelInfo, new ActionTimeout(30000), new RecordItemIndex(12));
            //repo.ApplicationUnderTest.lbl_SubirArchivoExcelInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(13));
            //Delay.Duration(6000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Siguiente2' at Center.", repo.ApplicationUnderTest.Siguiente2Info, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Siguiente2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(15));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Siguiente2' at Center.", repo.ApplicationUnderTest.Siguiente2Info, new RecordItemIndex(16));
            repo.ApplicationUnderTest.Siguiente2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_RevisionDeDatosCargados'", repo.ApplicationUnderTest.lbl_RevisionDeDatosCargadosInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.ApplicationUnderTest.lbl_RevisionDeDatosCargadosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Finalizar' at Center.", repo.ApplicationUnderTest.FinalizarInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Finalizar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_ProgramaDeCuotas'", repo.ApplicationUnderTest.lbl_ProgramaDeCuotasInfo, new ActionTimeout(30000), new RecordItemIndex(19));
            repo.ApplicationUnderTest.lbl_ProgramaDeCuotasInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}