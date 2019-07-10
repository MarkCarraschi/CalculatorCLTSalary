using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBrutoCalculo.Model
{
    class DesiredProduct{

        public DesiredProduct(double valueProduct, string nameProduct, 
                              string descriptionProduct, double necessityProduct){
            SetNameProduct(nameProduct);
            SetDescriptionProduct(descriptionProduct);
            SetNecessityProduct(necessityProduct);
            SetValueProduct(valueProduct);
        }

        //SET - METHODS
        public void SetNameProduct(string nameProduct){
            this.nameProduct = nameProduct;
        }

        public void SetDescriptionProduct(string descriptionProduct){
            this.descriptionProduct = descriptionProduct;
        }

        public void SetNecessityProduct(double necessityProduct){
            this.necessityProduct = necessityProduct;
        }

        public void SetValueProduct(double valueProduct){
            this.valueProduct = valueProduct;
        }

        //GET - METHODS
        public string GetNameProduct(){
            return nameProduct;
        }

        public string GetDescriptionProduct(){
            return descriptionProduct;
        }

        public double GetNecessityProduct(){
            return necessityProduct;
        }
        public double GetValueProduct(){
            return valueProduct;
        }

        String nameProduct, descriptionProduct;
        double valueProduct, necessityProduct;
    }
}
