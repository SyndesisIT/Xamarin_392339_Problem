using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Syn.DroidLinkerError
{
    public class ConstantsHelper
	{
#if DEBUG
        internal const string AppName = "SEOS Descargos";

        internal const string TrabajosPackageName = "unatec.uf.caronte";

        // Sincronización
        public const string DischargesSyncListener = "unatec.seos.discharges.sync.request";
        public const string TrabajosSyncListener = "unatec.uf.caronte.descargos.ServicioSincronizarDescargos";

        // Control previo
        public const string TrabajosControlPrevioListener = "unatec.uf.caronte.descargos.ServicioTieneCheckin";
        public const string DischargesControlPrevioListener = "unatec.seos.previouscheck.response";

        // SwitchTrabajos
        public const string TrabajosSwitchListener = "unatec.uf.caronte.descargos.ServicioAbrirSEOS";

        // SwitchDescargos
        public const string DischargesSwitchListener = "unatec.seos.discharges.open";

        // Ejecutar un descargo
        public const string DischargesExecuteListener = "unatec.seos.discharges.run";

        // Sincronizar un usuario
        internal const string TrabajosSyncUser = "unatec.uf.caronte.descargos.ServicioSincronizaUsuario";
        internal const string InstrumentationKey = "dd313e9c-0115-43e0-bf1e-643f939b57bb";
#endif
#if DEMO
		internal const string AppName = "SEOS Descargos DEMO";

        internal const string TrabajosPackageName = "unatec.uf.caronte.demo";

		// Sincronización
		public const string DischargesSyncListener = "unatec.seos.discharges.sync.request.DEMO";
		public const string TrabajosSyncListener = "unatec.uf.caronte.demo.descargos.ServicioSincronizarDescargos";

		// Control previo
		public const string TrabajosControlPrevioListener = "unatec.uf.caronte.demo.descargos.ServicioTieneCheckin";
		public const string DischargesControlPrevioListener = "unatec.seos.previouscheck.response.DEMO";

		// SwitchTrabajos
		public const string TrabajosSwitchListener = "unatec.uf.caronte.demo.descargos.ServicioAbrirSEOS";

		// SwitchDescargos
		public const string DischargesSwitchListener = "unatec.seos.discharges.open.DEMO";

		// Ejecutar un descargo
		public const string DischargesExecuteListener = "unatec.seos.discharges.run.DEMO"; 

        // Sincronizar un usuario
        internal const string TrabajosSyncUser = "unatec.uf.caronte.demo.descargos.ServicioSincronizaUsuario";
		internal const string InstrumentationKey = "de7ac05d-e8d8-4b53-a387-ded3d84e202a";
#endif
#if PRE
		internal const string AppName = "SEOS Descargos PRE";

        internal const string TrabajosPackageName = "unatec.uf.caronte.pre";

		// Sincronización
		public const string DischargesSyncListener = "unatec.seos.discharges.sync.request.PRE";
		public const string TrabajosSyncListener = "unatec.uf.caronte.pre.descargos.ServicioSincronizarDescargos";

		// Control previo
		public const string TrabajosControlPrevioListener = "unatec.uf.caronte.pre.descargos.ServicioTieneCheckin";
		public const string DischargesControlPrevioListener = "unatec.seos.previouscheck.response.PRE";

		// SwitchTrabajos
		public const string TrabajosSwitchListener = "unatec.uf.caronte.pre.descargos.ServicioAbrirSEOS";

		// SwitchDescargos
		public const string DischargesSwitchListener = "unatec.seos.discharges.open.PRE";

		// Ejecutar un descargo
		public const string DischargesExecuteListener = "unatec.seos.discharges.run.PRE"; 

        // Sincronizar un usuario
        internal const string TrabajosSyncUser = "unatec.uf.caronte.pre.descargos.ServicioSincronizaUsuario";

		internal const string InstrumentationKey = "de7ac05d-e8d8-4b53-a387-ded3d84e202a";
#endif
#if PRO
        internal const string AppName = "SEOS Descargos";

        internal const string TrabajosPackageName = "unatec.uf.caronte";

		// Sincronización
		public const string DischargesSyncListener = "unatec.seos.discharges.sync.request";
		public const string TrabajosSyncListener = "unatec.uf.caronte.descargos.ServicioSincronizarDescargos";

		// Control previo
		public const string TrabajosControlPrevioListener = "unatec.uf.caronte.descargos.ServicioTieneCheckin";
		public const string DischargesControlPrevioListener = "unatec.seos.previouscheck.response";

		// SwitchTrabajos
		public const string TrabajosSwitchListener = "unatec.uf.caronte.descargos.ServicioAbrirSEOS";

		// SwitchDescargos
		public const string DischargesSwitchListener = "unatec.seos.discharges.open";

		// Ejecutar un descargo
		public const string DischargesExecuteListener = "unatec.seos.discharges.run"; 

        // Sincronizar un usuario
        internal const string TrabajosSyncUser = "unatec.uf.caronte.descargos.ServicioSincronizaUsuario";
		internal const string InstrumentationKey = "4d0838be-c89b-4d65-b190-ee8d60a594db";
#endif
    }
}