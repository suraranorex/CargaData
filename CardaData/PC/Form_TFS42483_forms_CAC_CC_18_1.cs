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
    ///The Form_TFS42483_forms_CAC_CC_18_1 recording.
    /// </summary>
    [TestModule("4a526a3c-48a3-4023-b25b-048efffbab82", ModuleType.Recording, 1)]
    public partial class Form_TFS42483_forms_CAC_CC_18_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static Form_TFS42483_forms_CAC_CC_18_1 instance = new Form_TFS42483_forms_CAC_CC_18_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Form_TFS42483_forms_CAC_CC_18_1()
        {
            NombArch_TFS42483_forms_CAC_CC_18_1 = "TFS42483_forms_CAC_CC_18_1.xml";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Form_TFS42483_forms_CAC_CC_18_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _NombArch_TFS42483_forms_CAC_CC_18_1;

        /// <summary>
        /// Gets or sets the value of variable NombArch_TFS42483_forms_CAC_CC_18_1.
        /// </summary>
        [TestVariable("363d58f8-f4bc-4685-b306-c49d5c65c67b")]
        public string NombArch_TFS42483_forms_CAC_CC_18_1
        {
            get { return _NombArch_TFS42483_forms_CAC_CC_18_1; }
            set { _NombArch_TFS42483_forms_CAC_CC_18_1 = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Utilidades1' at Center.", repo.ApplicationUnderTest.Utilidades1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Utilidades1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ImportarDatosAdministrativos'", repo.ApplicationUnderTest.ImportarDatosAdministrativosInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.ImportarDatosAdministrativosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Examinar2' at Center.", repo.ApplicationUnderTest.Btn_Examinar2Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Btn_Examinar2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'Ventana_Emergente_Abrir'", repo.Ventana_Emergente_Abrir.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.Ventana_Emergente_Abrir.SelfInfo.WaitForExists(30000);
            
            // Ventana Emergente
            Report.Log(ReportLevel.Info, "Section", "Ventana Emergente", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VentanaEmergente_Examinar.BarraInferior' at Center.", repo.VentanaEmergente_Examinar.BarraInferiorInfo, new RecordItemIndex(5));
            repo.VentanaEmergente_Examinar.BarraInferior.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NombArch_TFS42483_forms_CAC_CC_18_1'.", new RecordItemIndex(6));
            Keyboard.Press(NombArch_TFS42483_forms_CAC_CC_18_1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Ventana_Emergente_Abrir.ButtonAbrir' at 47;13.", repo.Ventana_Emergente_Abrir.ButtonAbrirInfo, new RecordItemIndex(8));
            repo.Ventana_Emergente_Abrir.ButtonAbrir.Click("47;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'ContinueOnFail.Copy_of_lbl_100Percent'", repo.ContinueOnFail.Copy_of_lbl_100PercentInfo, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.ContinueOnFail.Copy_of_lbl_100PercentInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_resultadoFormCargaAsistMedica'", repo.ApplicationUnderTest.lbl_resultadoFormCargaAsistMedicaInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.ApplicationUnderTest.lbl_resultadoFormCargaAsistMedicaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Datos importados correctamente.') on item 'ApplicationUnderTest.lbl_Resultado_DatosImportadosFormAsistMed'.", repo.ApplicationUnderTest.lbl_Resultado_DatosImportadosFormAsistMedInfo, new RecordItemIndex(14));
            Validate.AttributeContains(repo.ApplicationUnderTest.lbl_Resultado_DatosImportadosFormAsistMedInfo, "InnerText", "Datos importados correctamente.");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
