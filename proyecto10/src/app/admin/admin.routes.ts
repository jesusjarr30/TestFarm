import { Routes } from '@angular/router';
import { PrincipalComponent } from './principal/principal.component';
import { ModificarProductosComponent } from './modificar-productos/modificar-productos.component';

export const ADMIN_ROUTES: Routes =[
    {path : '', component: PrincipalComponent},
    {path : 'ModificarProductos', component: ModificarProductosComponent},
]