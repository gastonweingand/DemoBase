///////////////////////////////////////////////////////////
//  Familia.cs
//  Implementation of the Class Familia
//  Generated by Enterprise Architect
//  Created on:      05-may.-2022 21:16:57
//  Original author: gasto
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Services.DomainModel.Security.Composite
{
	/// <summary>
	/// This class (a) defines behaviour for components having children, (b) stores
	/// child components, and (c) implements child-related operations in the Component
	/// interface.
	/// </summary>
	public class Familia : Component {

		private List<Component> childrens = new List<Component>();

        public Familia(Component component, string nombre)
        {
			childrens.Add(component);
			Nombre = nombre;
        }

		public string Nombre { get; set; }


		public List<Component> GetChildrens()
        {
			return childrens;
        }
		/// 
		/// <param name="component"></param>
		public override void Add(Component component){
			childrens.Add(component);
		}

        public override int ChildrenCount()
        {
			return childrens.Count;
        }

        /// 
        /// <param name="component"></param>
        public override void Remove(Component component){			
			childrens.RemoveAll(o => o.IdComponent == component.IdComponent);
		}

	}//end Familia

}//end namespace Composite