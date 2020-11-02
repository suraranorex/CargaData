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

namespace CardaData.CC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CambioDatos recording.
    /// </summary>
    [TestModule("1cad4c0f-90e0-4fbf-8a34-145edb70029d", ModuleType.Recording, 1)]
    public partial class CambioDatos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static CambioDatos instance = new CambioDatos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CambioDatos()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CambioDatos Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Adminisracion' at Center.", repo.ApplicationUnderTest.AdminisracionInfo, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.Adminisracion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Utilidades1' at Center.", repo.ApplicationUnderTest.Utilidades1Info, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.Utilidades1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CambioDeDatos' at Center.", repo.ApplicationUnderTest.CambioDeDatosInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.CambioDeDatos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_CambioDeDatos'", repo.ApplicationUnderTest.lbl_CambioDeDatosInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.ApplicationUnderTest.lbl_CambioDeDatosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Ejecutar' at Center.", repo.ApplicationUnderTest.EjecutarInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Ejecutar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(8));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'F5' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.F5, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_ResultadoDataChengeCCWeb'", repo.ApplicationUnderTest.lbl_ResultadoDataChengeCCWebInfo, new ActionTimeout(30000), new RecordItemIndex(10));
            repo.ApplicationUnderTest.lbl_ResultadoDataChengeCCWebInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Estado_Completado'", repo.ApplicationUnderTest.Estado_CompletadoInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.ApplicationUnderTest.Estado_CompletadoInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Completado') on item 'ApplicationUnderTest.Estado_Completado'.", repo.ApplicationUnderTest.Estado_CompletadoInfo, new RecordItemIndex(12));
            Validate.AttributeContains(repo.ApplicationUnderTest.Estado_CompletadoInfo, "InnerText", "Completado");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
