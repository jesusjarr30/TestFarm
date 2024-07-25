import { Routes } from '@angular/router';
import { NavBarComponent } from './shared/componets/nav-bar/nav-bar.component';
import { Component } from '@angular/core';

export const routes: Routes = [

    //establecer las rutas asi como las rutas 

    { path: 'home', component: NavBarComponent },

    {
        path: '',
        loadChildren: () => import('./admin/admin.routes').then(m => m.ADMIN_ROUTES)
    },
    {
        path: 'login',
        loadChildren: () => import('./auth/auth.routes').then(m => m.AUTH_ROUTES)
    }


];
