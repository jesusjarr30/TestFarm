import { Component, OnInit } from '@angular/core';
import { product } from '../../core/models/product';
import { ProductServiceService } from '../../core/services/product-service.service';
import { CommonModule } from '@angular/common';



@Component({
  selector: 'app-view-productos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './view-productos.component.html',
  styleUrl: './view-productos.component.css'
})
export class ViewProductosComponent implements OnInit{
  
  listaProductos: product[] | undefined;

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
}
