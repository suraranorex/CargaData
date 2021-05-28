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
    ///The SubMenu_UsuariosY_Seguridad recording.
    /// </summary>
    [TestModule("12da9e2f-a851-48f1-84d2-67cfa01b7d62", ModuleType.Recording, 1)]
    public partial class SubMenu_UsuariosY_Seguridad : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static SubMenu_UsuariosY_Seguridad instance = new SubMenu_UsuariosY_Seguridad();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SubMenu_UsuariosY_Seguridad()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SubMenu_UsuariosY_Seguridad Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Menu.SubMenuUsuariosYSeguridad' at Center.", repo.ApplicationUnderTest.Menu.SubMenuUsuariosYSeguridadInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Menu.SubMenuUsuariosYSeguridad.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.txt_Usuarios'", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.txt_UsuariosInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.txt_UsuariosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
