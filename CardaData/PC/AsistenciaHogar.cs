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
    ///The AsistenciaHogar recording.
    /// </summary>
    [TestModule("2513558a-ba10-4788-8ab1-b588ffff9baf", ModuleType.Recording, 1)]
    public partial class AsistenciaHogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static AsistenciaHogar instance = new AsistenciaHogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AsistenciaHogar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AsistenciaHogar Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_AsistHogar'", repo.ApplicationUnderTest.lbl_AsistHogarInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.lbl_AsistHogarInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_BuscarAsistHogar' at Center.", repo.ApplicationUnderTest.Btn_BuscarAsistHogarInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Btn_BuscarAsistHogar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.FilaAsistHogar'", repo.ApplicationUnderTest.FilaAsistHogarInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.FilaAsistHogarInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Editar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Editar_AsistAutosInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Btn_Editar_AsistAutos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Actualizar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Actualizar_AsistAutosInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Btn_Actualizar_AsistAutos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Copy_of_Btn_Actualizar_AsistAutos'", repo.ApplicationUnderTest.Copy_of_Btn_Actualizar_AsistAutosInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.ApplicationUnderTest.Copy_of_Btn_Actualizar_AsistAutosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
