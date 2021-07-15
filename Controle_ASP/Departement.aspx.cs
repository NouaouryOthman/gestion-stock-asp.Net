using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace Controle_ASP
{
    public partial class Departement : System.Web.UI.Page
    {
        TacheContext tacheContext = new TacheContext();
        private void chargerGrid()
        {
            gVDepartements.DataSource = (from emp in tacheContext.departements select emp).ToList();
            gVDepartements.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            tbIdDeparteament.ReadOnly = true;
            chargerGrid();
        }

        protected void gVDepartements_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(gVDepartements.SelectedValue.ToString());
            Entity.Departement dept = (from val in tacheContext.departements where val.Id == id select val).Single();
            tbIdDeparteament.Text = dept.Id.ToString();
            tbNomDepartement.Text = dept.Nom;
            tbVilleDepartement.Text = dept.Ville;
        }

        protected void btMAJ_Click(object sender, EventArgs e)
        {
            Int32 id = int.Parse(gVDepartements.SelectedValue.ToString());
            Entity.Departement dept = (from V in tacheContext.departements where V.Id == id select V).Single();
            dept.Nom = tbNomDepartement.Text;
            dept.Ville = tbVilleDepartement.Text;
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btAjouter_Click(object sender, EventArgs e)
        {
            Entity.Departement dept = new Entity.Departement();
            dept.Nom = tbNomDepartement.Text;
            dept.Ville = tbVilleDepartement.Text;
            tacheContext.departements.Add(dept);
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btSupprimer_Click(object sender, EventArgs e)
        {
            Int32 id = int.Parse(gVDepartements.SelectedValue.ToString());
            Entity.Departement dept = (from V in tacheContext.departements where V.Id == id select V).Single();
            tacheContext.departements.Remove(dept);
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void Recherche_Click(object sender, EventArgs e)
        {
            string nom = tbNomDepartement.Text;
            string ville = tbVilleDepartement.Text;
            List<Entity.Departement> dept = (from departement in tacheContext.departements
                                       where departement.Nom == nom || departement.Ville == ville
                                       select departement).ToList();
            gVDepartements.DataSource = dept;
            gVDepartements.DataBind();
        }
    }
}