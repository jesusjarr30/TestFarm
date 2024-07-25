import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { RegistroProductosComponent } from './registro-productos/registro-productos.component';

export const AUTH_ROUTES: Routes = [

    {path : '', component: LoginComponent},
    {path: 'register', component: RegisterComponent},
    {path: 'Rproductos',component: RegistroProductosComponent}

]