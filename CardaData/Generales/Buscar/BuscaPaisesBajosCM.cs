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

namespace CardaData.Generales.Buscar
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscaPaisesBajosCM recording.
    /// </summary>
    [TestModule("62f94b97-b4c0-4dec-bf48-78a1c2570c53", ModuleType.Recording, 1)]
    public partial class BuscaPaisesBajosCM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static BuscaPaisesBajosCM instance = new BuscaPaisesBajosCM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscaPaisesBajosCM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscaPaisesBajosCM Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FlechitaPaisCM' at Center.", repo.ApplicationUnderTest.FlechitaPaisCMInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FlechitaPaisCM.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.SelectPrimerItemPaisesBajos' at Center.", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.SelectPrimerItemPaisesBajosInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.SelectPrimerItemPaisesBajos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_FlechitaBuscaPaisCC'", repo.ApplicationUnderTest.Copy_of_FlechitaBuscaPaisCCInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.Copy_of_FlechitaBuscaPaisCCInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FlechitaProvinciaCM' at Center.", repo.ApplicationUnderTest.FlechitaProvinciaCMInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FlechitaProvinciaCM.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.Copy_of_SelectPrimerItem' at Center.", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.Copy_of_SelectPrimerItemInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.Copy_of_SelectPrimerItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_FlechitaProvinciaCM'", repo.ApplicationUnderTest.Copy_of_FlechitaProvinciaCMInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.ApplicationUnderTest.Copy_of_FlechitaProvinciaCMInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.txt_PaisBajoAmsterdamCM'", repo.ApplicationUnderTest.txt_PaisBajoAmsterdamCMInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.ApplicationUnderTest.txt_PaisBajoAmsterdamCMInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
