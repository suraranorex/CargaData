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

namespace CardaData.Generales.Menu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AB_NavAdmin_SubM1_SubM2 recording.
    /// </summary>
    [TestModule("0f68f6f1-a478-48ec-a30b-35ccf3ecc8a3", ModuleType.Recording, 1)]
    public partial class AB_NavAdmin_SubM1_SubM2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static AB_NavAdmin_SubM1_SubM2 instance = new AB_NavAdmin_SubM1_SubM2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AB_NavAdmin_SubM1_SubM2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AB_NavAdmin_SubM1_SubM2 Instance
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
        /// Gets or sets the value of variable SubM1.
        /// </summary>
        [TestVariable("5797f7d2-4586-45c4-88e4-1514587120fd")]
        public string SubM1
        {
            get { return repo.SubM1; }
            set { repo.SubM1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SubM2.
        /// </summary>
        [TestVariable("3e209b49-f075-415b-b2ff-947c6957ea01")]
        public string SubM2
        {
            get { return repo.SubM2; }
            set { repo.SubM2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Nav_MenuAdmin_ab' at Center.", repo.ApplicationUnderTest.Nav_MenuAdmin_abInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Nav_MenuAdmin_ab.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'ApplicationUnderTest.Nav_SubM1'", repo.ApplicationUnderTest.Nav_SubM1Info, new ActionTimeout(40000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.Nav_SubM1Info.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Nav_SubM1' at Center.", repo.ApplicationUnderTest.Nav_SubM1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Nav_SubM1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'ApplicationUnderTest.Nav_SubM2'", repo.ApplicationUnderTest.Nav_SubM2Info, new ActionTimeout(40000), new RecordItemIndex(4));
            repo.ApplicationUnderTest.Nav_SubM2Info.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Nav_SubM2' at Center.", repo.ApplicationUnderTest.Nav_SubM2Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Nav_SubM2.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
