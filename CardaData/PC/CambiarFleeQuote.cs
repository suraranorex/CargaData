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
    ///The CambiarFleeQuote recording.
    /// </summary>
    [TestModule("fda8659e-f1aa-4105-a63c-cf45acd423f8", ModuleType.Recording, 1)]
    public partial class CambiarFleeQuote : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static CambiarFleeQuote instance = new CambiarFleeQuote();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CambiarFleeQuote()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CambiarFleeQuote Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_ParametrosDeSecuencia'", repo.ApplicationUnderTest.lbl_ParametrosDeSecuenciaInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.lbl_ParametrosDeSecuenciaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_NumPag' at Center.", repo.ApplicationUnderTest.txt_NumPagInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.txt_NumPag.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.txt_NumPag'.", repo.ApplicationUnderTest.txt_NumPagInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.txt_NumPag.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5' with focus on 'ApplicationUnderTest.txt_NumPag'.", repo.ApplicationUnderTest.txt_NumPagInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.txt_NumPag.PressKeys("5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.fila_ExecuteFleetQuoteAsynchronouslySura'", repo.ApplicationUnderTest.fila_ExecuteFleetQuoteAsynchronouslySuraInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.ApplicationUnderTest.fila_ExecuteFleetQuoteAsynchronouslySuraInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.fila_ExecuteFleetQuoteAsynchronouslySura' at Center.", repo.ApplicationUnderTest.fila_ExecuteFleetQuoteAsynchronouslySuraInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.fila_ExecuteFleetQuoteAsynchronouslySura.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_ExecuteFleetQuoteAsynchronouslySura'", repo.ApplicationUnderTest.lbl_ExecuteFleetQuoteAsynchronouslySuraInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.ApplicationUnderTest.lbl_ExecuteFleetQuoteAsynchronouslySuraInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Editar' at Center.", repo.ApplicationUnderTest.Btn_EditarInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Btn_Editar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Btn_Actualizar_ValorSec'", repo.ApplicationUnderTest.Btn_Actualizar_ValorSecInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.ApplicationUnderTest.Btn_Actualizar_ValorSecInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.OptionButton_No' at Center.", repo.ApplicationUnderTest.OptionButton_NoInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.OptionButton_No.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Actualizar_ValorSec' at Center.", repo.ApplicationUnderTest.Btn_Actualizar_ValorSecInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Btn_Actualizar_ValorSec.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Btn_Editar'", repo.ApplicationUnderTest.Btn_EditarInfo, new ActionTimeout(30000), new RecordItemIndex(12));
            repo.ApplicationUnderTest.Btn_EditarInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
