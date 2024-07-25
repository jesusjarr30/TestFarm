import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { product } from '../models/product';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  private apiUrl = 'http://localhost:8080/Product';

  constructor(private http: HttpClient) { }

  getProducts(): Observable<product[]> {
    console.log('Se llama a '+ `${this.apiUrl}/getProduct`);
    return this.http.get<product[]>(`${this.apiUrl}/getProduct`);
  }
  //registra producto

  postProduct(product: any) {
    console.log('Se llama a '+ `${this.apiUrl}/addProduct`);
    console.log("El producto es "+product);
    return this.http.post<product>(`${this.apiUrl}/addProduct`, product);
  }

  Modificar(product: any){
    return this.http.put(`${this.apiUrl}/EditarProducto`, product)

  }

  Eliminaar(product: any){
    //solo es necesario enmviar el id del articulo que se quiera eliminar 
    return this.http.delete(`${this.apiUrl}/DeleteProduct`, { params: { id: product } });
  }


}
