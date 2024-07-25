import { Component } from '@angular/core';
import { Product, product } from '../../core/models/product';
import { FormsModule } from '@angular/forms';
import { ProductServiceService } from '../../core/services/product-service.service';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-registro-productos',
  standalone: true,
  imports: [FormsModule,HttpClientModule],
  templateUrl: './registro-productos.component.html',
  styleUrl: './registro-productos.component.css'
})
export class RegistroProductosComponent {
  
    paraRegistro:product   = new Product();

    constructor(private productService: ProductServiceService) {}

    onSubmint(){

      if(this.paraRegistro.title.length !=0 && this.paraRegistro.description.length != 0 && this.paraRegistro.imagen.length !=0){
        this.productService.postProduct(this.paraRegistro).subscribe(
          response => {
            console.log('Producto registrado:', response);
             // Actualizar la lista de productos después de registrar uno nuevo
          },
          error => {
            console.error('Error al registrar el producto:', error);
          }
        );
      } else {
        console.log("Es necesario llenar todos los campos");
        console.log("titulo "+this.paraRegistro.title);
        console.log("titulo "+this.paraRegistro.description);
        console.log("titulo "+this.paraRegistro.imagen);
      }
    }
  

}
