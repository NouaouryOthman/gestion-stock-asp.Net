using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace Controle_ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TacheContext tacheContext = new TacheContext();
        private void chargerGrid()
        {
            gVTaches.DataSource = (from taches in tacheContext.taches select taches).ToList();
            gVTaches.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            chargerGrid();
            tbIdTache.ReadOnly = true;
            if (!Page.IsPostBack)
            {
                ddlEmployeTache.DataSource = (from tache in tacheContext.employes select tache).ToList();
                ddlEmployeTache.DataTextField = "Nom";
                ddlEmployeTache.DataValueField = "Id";
                ddlEmployeTache.DataBind();
            }
        }

        protected void gVTaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 id = int.Parse(gVTaches.SelectedValue.ToString());
            Entity.Tache tache = (from val in tacheContext.taches where val.Id == id select val).Single();
            tbIdTache.Text = tache.Id.ToString();
            tbDescriptionTache.Text = tache.Description;
        }

        protected void btMAJ_Click(object sender, EventArgs e)
        {
            Int32 id = int.Parse(gVTaches.SelectedValue.ToString());
            Entity.Tache tache = (from val in tacheContext.taches where val.Id == id select val).Single();
            Int32 idEmp = int.Parse(ddlEmployeTache.SelectedValue.ToString());
            Entity.Employe emp = (from V in tacheContext.employes where V.Id == idEmp select V).Single();
            tache.Description = tbDescriptionTache.Text;
            tache.Employe = emp;
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btAjouter_Click(object sender, EventArgs e)
        {
            Entity.Tache tache = new Entity.Tache();
            tache.Description = tbDescriptionTache.Text;
            Int32 idEmp = int.Parse(ddlEmployeTache.SelectedValue.ToString());
            Entity.Employe emp = (from V in tacheContext.employes where V.Id == idEmp select V).Single();
            tache.Employe = emp;
            tacheContext.taches.Add(tache);
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gVTaches.SelectedValue.ToString());
            Entity.Tache tache = (from val in tacheContext.taches where val.Id == id select val).Single();
            tacheContext.taches.Remove(tache);
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btRecherche_Click(object sender, EventArgs e)
        {
            Int32 idEmp = int.Parse(ddlEmployeTache.SelectedValue.ToString());
            Entity.Employe emp = tacheContext.employes.Find(idEmp);
            string desc = tbDescriptionTache.Text;
            List<Entity.Tache> taches = (from tache in tacheContext.taches
                                         where tache.Employe.Id == emp.Id || tache.Description == desc
                                         select tache).ToList();
            gVTaches.DataSource = taches;
            gVTaches.DataBind();
        }
    }
}