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

namespace CardaData.PC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CargaXML recording.
    /// </summary>
    [TestModule("0884ce06-c3a1-46b2-bccb-d50fc1172cd7", ModuleType.Recording, 1)]
    public partial class CargaXML : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static CargaXML instance = new CargaXML();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CargaXML()
        {
            NombArchCACGCCPA = "CACGCCPA_AP_01.xml";
            NombreArchivoXML = "sura_ca7_vehicle_assistance.xml";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CargaXML Instance
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
        /// Gets or sets the value of variable NombArchCACGCCPA.
        /// </summary>
        [TestVariable("cd97bd5b-cce5-4470-ab64-c7c7b896349d")]
        public string NombArchCACGCCPA
        {
            get { return repo.NombArchCACGCCPA; }
            set { repo.NombArchCACGCCPA = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NombreArchivoXML.
        /// </summary>
        [TestVariable("05771ab3-fe5e-4cce-99f8-a9060059ca5c")]
        public string NombreArchivoXML
        {
            get { return repo.NombreArchivoXML; }
            set { repo.NombreArchivoXML = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Utilidades1' at Center.", repo.ApplicationUnderTest.Utilidades1Info, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.Utilidades1.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ImportarDatosAdministrativos'", repo.ApplicationUnderTest.ImportarDatosAdministrativosInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.ImportarDatosAdministrativosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Examinar2' at Center.", repo.ApplicationUnderTest.Btn_Examinar2Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Btn_Examinar2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'Ventana_Emergente_Abrir'", repo.Ventana_Emergente_Abrir.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.Ventana_Emergente_Abrir.SelfInfo.WaitForExists(30000);
            
            // Ventana Emergente
            Report.Log(ReportLevel.Info, "Section", "Ventana Emergente", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VentanaEmergente_Examinar.Escritorio' at Center.", repo.VentanaEmergente_Examinar.EscritorioInfo, new RecordItemIndex(5));
            repo.VentanaEmergente_Examinar.Escritorio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\Carga_Inicial_QA\\PC\\tablas'.", new RecordItemIndex(6));
            Keyboard.Press("C:\\Carga_Inicial_QA\\PC\\tablas");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(7));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VentanaEmergente_Examinar.BarraInferior' at Center.", repo.VentanaEmergente_Examinar.BarraInferiorInfo, new RecordItemIndex(8));
            repo.VentanaEmergente_Examinar.BarraInferior.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NombreArchivoXML'.", new RecordItemIndex(9));
            Keyboard.Press(NombreArchivoXML);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ventana_Emergente_Abrir.ButtonAbrir' at 47;13.", repo.Ventana_Emergente_Abrir.ButtonAbrirInfo, new RecordItemIndex(11));
            repo.Ventana_Emergente_Abrir.ButtonAbrir.Click("47;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 1m to exist. Associated repository item: 'ContinueOnFail.Copy_of_lbl_100Percent'", repo.ContinueOnFail.Copy_of_lbl_100PercentInfo, new ActionTimeout(60000), new RecordItemIndex(13));
                repo.ContinueOnFail.Copy_of_lbl_100PercentInfo.WaitForExists(60000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_resultadoFormCargaAsistMedica'", repo.ApplicationUnderTest.lbl_resultadoFormCargaAsistMedicaInfo, new ActionTimeout(30000), new RecordItemIndex(14));
            repo.ApplicationUnderTest.lbl_resultadoFormCargaAsistMedicaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_resultadoFormCargaAsistMedica'", repo.ApplicationUnderTest.lbl_resultadoFormCargaAsistMedicaInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.ApplicationUnderTest.lbl_resultadoFormCargaAsistMedicaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Datos importados correctamente.') on item 'ApplicationUnderTest.lbl_Resultado_DatosImportadosFormAsistMed'.", repo.ApplicationUnderTest.lbl_Resultado_DatosImportadosFormAsistMedInfo, new RecordItemIndex(18));
            Validate.AttributeContains(repo.ApplicationUnderTest.lbl_Resultado_DatosImportadosFormAsistMedInfo, "InnerText", "Datos importados correctamente.");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
