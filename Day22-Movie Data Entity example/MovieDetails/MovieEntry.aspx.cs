using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using MovieDetailsData;

namespace MovieDetails
{
    public partial class MovieEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieDetailsEntities = new MovieDetailsEntities();
            movie movieobj = new movie();
            movieobj.Name = txtM_name.Text;
            movieobj.MovieType = txtM_type.Text;
            movieobj.MovieDesc = txtM_desc.Text;
            movieDetailsEntities.movies.Add(movieobj);
            movieDetailsEntities.SaveChanges();
            lblResult.Text = "Movie added succesfully";

        }

        protected void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieDetailsEntities = new MovieDetailsEntities();
            movie movieobj = new movie();
            movieobj.M_Id = Convert.ToInt32(txtMovieID.Text);
            movieobj.Name = txtM_name.Text;
            movieobj.MovieType = txtM_type.Text;
            movieobj.MovieDesc = txtM_desc.Text;
            movieDetailsEntities.Entry(movieobj).State = EntityState.Modified;
            movieDetailsEntities.SaveChanges();
            lblResult.Text = "Movie Updated";

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieDetailsEntities = new MovieDetailsEntities();
            var result = movieDetailsEntities.movies.ToList().Find(obj => obj.M_Id == Convert.ToInt32(txtMovieID.Text));//select * from movie where id=''
            txtM_name.Text = result.Name;
            txtM_type.Text = result.MovieType;
            txtM_desc.Text = result.MovieDesc;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MovieDetailsEntities movieDetailsEntities = new MovieDetailsEntities();
            movie movieobj = new movie();
            movieobj.M_Id = Convert.ToInt32(txtMovieID.Text);
            movieobj.Name = txtM_name.Text;
            movieobj.MovieType = txtM_type.Text;
            movieobj.MovieDesc = txtM_desc.Text;
            movieDetailsEntities.Entry(movieobj).State = EntityState.Deleted;
            movieDetailsEntities.SaveChanges();
            lblResult.Text = "Movie Deleted";
        }
    }
}