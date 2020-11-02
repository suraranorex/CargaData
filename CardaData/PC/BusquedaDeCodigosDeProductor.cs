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
    ///The BusquedaDeCodigosDeProductor recording.
    /// </summary>
    [TestModule("3ae507f2-717e-4833-840c-544845243977", ModuleType.Recording, 1)]
    public partial class BusquedaDeCodigosDeProductor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static BusquedaDeCodigosDeProductor instance = new BusquedaDeCodigosDeProductor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BusquedaDeCodigosDeProductor()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BusquedaDeCodigosDeProductor Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductor'", repo.ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductorInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductorInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_CodProductorBuscar' at Center.", repo.ApplicationUnderTest.txt_CodProductorBuscarInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.txt_CodProductorBuscar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.txt_CodProductorBuscar'.", repo.ApplicationUnderTest.txt_CodProductorBuscarInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.txt_CodProductorBuscar.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '6254' with focus on 'ApplicationUnderTest.txt_CodProductorBuscar'.", repo.ApplicationUnderTest.txt_CodProductorBuscarInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.txt_CodProductorBuscar.PressKeys("6254");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_BuscarCodPAS' at Center.", repo.ApplicationUnderTest.Btn_BuscarCodPASInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Btn_BuscarCodPAS.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
