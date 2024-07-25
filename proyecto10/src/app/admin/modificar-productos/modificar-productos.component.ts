import { Component, OnInit,NgModule } from '@angular/core';
import { Product, product } from '../../core/models/product';
import { ProductServiceService } from '../../core/services/product-service.service';
import { FormsModule } from '@angular/forms';  
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-modificar-productos',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './modificar-productos.component.html',
  styleUrl: './modificar-productos.component.css'
})
export class ModificarProductosComponent  implements OnInit{

  listaProductos: product[] | undefined;

  selectP : Product = new Product();

  constructor(private productService: ProductServiceService) { }

  ngOnInit(): void {
    this.getProductos();
  }
  getProductos(): void {
    this.productService.getProducts().subscribe(
      (products: product[]) => {
        this.listaProductos = products;
        console.log(this.listaProductos);
      },
      (error) => {
        console.error('Error retrieving products:', error);
      }
    );
  }

  selecionar(p: Product){
    //aqui se tiene que haceer la carga del producto selecionado a el producto que tenemos en los chehcbo
    this.selectP = p;

  }

  Modificar(){
      console.log("se esta modificando");
      this.productService.Modificar(this.selectP).subscribe(
        response => {
          console.log('Respuesta del servidor:', response);
          // Aquí puedes manejar la respuesta, por ejemplo, mostrando un mensaje de éxito
          alert('Producto editado exitosamente');
        },
        error => {
          console.error('Error al editar el producto:', error);
          // Aquí puedes manejar el error, por ejemplo, mostrando un mensaje de error
          alert('Hubo un error al editar el producto');
        }
      );
      this.getProductos();
  }

  Eliminar(){
    console.log("se esta modificando");
    this.productService.Eliminaar(this.selectP.id).subscribe(
      response => {
        console.log('Respuesta del servidor:', response);
        // Aquí puedes manejar la respuesta, por ejemplo, mostrando un mensaje de éxito
        alert('Producto eliminado exitosamente');
      },
      error => {
        console.error('Error al editar el producto:', error);
        // Aquí puedes manejar el error, por ejemplo, mostrando un mensaje de error
        alert('Hubo un error al editar el producto');
      }
    );

  }

  
}
