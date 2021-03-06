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
    ///The NuevoPlanEnlatado recording.
    /// </summary>
    [TestModule("0b29f461-a2a0-480f-a380-83ce697c2156", ModuleType.Recording, 1)]
    public partial class NuevoPlanEnlatado : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static NuevoPlanEnlatado instance = new NuevoPlanEnlatado();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NuevoPlanEnlatado()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NuevoPlanEnlatado Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_Nuevo' at Center.", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_NuevoInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_Nuevo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_NuevoPlanEnlatado' at Center.", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_NuevoPlanEnlatadoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_NuevoPlanEnlatado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.txt_NuevoPlanEnlatado'", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.txt_NuevoPlanEnlatadoInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.txt_NuevoPlanEnlatadoInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
