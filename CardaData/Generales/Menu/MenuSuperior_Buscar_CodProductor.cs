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
    ///The MenuSuperior_Buscar_CodProductor recording.
    /// </summary>
    [TestModule("f8d960d4-d734-4a5f-b6a6-8157840de5c4", ModuleType.Recording, 1)]
    public partial class MenuSuperior_Buscar_CodProductor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static MenuSuperior_Buscar_CodProductor instance = new MenuSuperior_Buscar_CodProductor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MenuSuperior_Buscar_CodProductor()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MenuSuperior_Buscar_CodProductor Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Menu_Buscar' at CenterRight.", repo.ApplicationUnderTest.Menu_BuscarInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Menu_Buscar.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubMenu_CodigosDeProductor' at Center.", repo.ApplicationUnderTest.SubMenu_CodigosDeProductorInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SubMenu_CodigosDeProductor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductor'", repo.ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductorInfo, new ActionTimeout(15000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductorInfo.WaitForExists(15000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
