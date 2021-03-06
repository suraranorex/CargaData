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

namespace CardaData.Generales.CargaArchivo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ContinuarProceso recording.
    /// </summary>
    [TestModule("99a4628f-c5e5-472e-98b8-5283decce00c", ModuleType.Recording, 1)]
    public partial class ContinuarProceso : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static ContinuarProceso instance = new ContinuarProceso();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ContinuarProceso()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ContinuarProceso Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 3m to exist. Associated repository item: 'ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503'", repo.ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503Info, new ActionTimeout(180000), new RecordItemIndex(2));
                repo.ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503Info.WaitForExists(180000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_AceptarError' at Center.", repo.ApplicationUnderTest.btn_AceptarErrorInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.btn_AceptarError.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_FinalizarCargaDataPC' at Center.", repo.ApplicationUnderTest.btn_FinalizarCargaDataPCInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.btn_FinalizarCargaDataPC.Click();
            //Delay.Milliseconds(0);
            
            try {
                //Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 3m to exist. Associated repository item: 'ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503'", repo.ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503Info, new ActionTimeout(180000), new RecordItemIndex(5));
                //repo.ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503Info.WaitForExists(180000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_AceptarError' at Center.", repo.ApplicationUnderTest.btn_AceptarErrorInfo, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.btn_AceptarError.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1h.", new RecordItemIndex(7));
            //Delay.Duration(3600000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'F5' Press with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.Self);
            Keyboard.Press(System.Windows.Forms.Keys.F5, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15m to exist. Associated repository item: 'ApplicationUnderTest.lbl_ResultadosDeImportacion'", repo.ApplicationUnderTest.lbl_ResultadosDeImportacionInfo, new ActionTimeout(900000), new RecordItemIndex(9));
            repo.ApplicationUnderTest.lbl_ResultadosDeImportacionInfo.WaitForExists(900000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (InnerText~'Datos importados correctamente') on item 'ApplicationUnderTest.lbl_Resulyado_DatosImportados'.", repo.ApplicationUnderTest.lbl_Resulyado_DatosImportadosInfo, new RecordItemIndex(10));
            Validate.AttributeRegex(repo.ApplicationUnderTest.lbl_Resulyado_DatosImportadosInfo, "InnerText", new Regex("Datos importados correctamente"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
