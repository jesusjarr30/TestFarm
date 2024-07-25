export interface product {
    id: string;
    title: string;
    description: string;  // Asegúrate de que coincide con los datos de la API
    imagen: string;
    creatAt: number;  // La API devuelve un timestamp, no un Date
    softDelete: boolean;

    
  }
  export class Product implements product {
    id: string = '';
    title: string = '';
    description: string = '';
    imagen: string = '';
    creatAt: number = 0;
    softDelete: boolean = false;
  
    constructor(init?: Partial<Product>) {
      Object.assign(this, init);
    }
}

