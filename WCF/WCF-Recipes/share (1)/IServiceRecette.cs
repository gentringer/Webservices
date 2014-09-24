﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace share
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IServiceRecette
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<Recette> rechercheParNomIngredient(String nom);

        [OperationContract]
        Recette newRecette(String nom);

        [OperationContract]
        Ingredient newIngredient(String nom);

        [OperationContract]
        List<Recette> searchRecette(Ingredient ingr);

        [OperationContract]
        String getNomIngre(Ingredient ing);

        [OperationContract]
        String getNomRecette(Recette rec);

        [OperationContract]
        String deletecourante(String nom);

        [OperationContract]
        String addRecette(Recette recette);

        [OperationContract]
        List<Recette> getInfoCourante();


        [OperationContract]
        int MyMethod();

        [OperationContract]
        void initializebase();

        [OperationContract]
        List<Recette> listeBase();
       
       

        // TODO: Add your service operations here
    }

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IBase
    {
        [OperationContract]
        List<Recette> basedelaRecettes();


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations

   

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    

    [DataContract]
    public class Ingredient
    {
        String nom;

        [DataMember]
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

    }

   
    public class Recette
    {
        String nom;
        List<Ingredient> listeingredients = new List<Ingredient>();

        [DataMember]
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [DataMember]
        public List<Ingredient> Listeingredients
        {
            get { return listeingredients; }
            set { listeingredients = value; }
        }

    }
   /* [DataContract]
    public class SelectionCourante
    {
        Recette recettecourante;


        [DataMember]
        public Recette Recettecourante
        {
            get { return recettecourante; }
            set { recettecourante = value; }
        }
        

    }*/

}
