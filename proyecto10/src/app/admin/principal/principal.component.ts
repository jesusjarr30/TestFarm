import { Component } from '@angular/core';
import { NavBarComponent } from '../../shared/componets/nav-bar/nav-bar.component';
import { FooterComponent } from "../../shared/componets/footer/footer.component";
import { ViewProductosComponent } from "../view-productos/view-productos.component";
import { PromocionesComponent } from "../promociones/promociones.component";

@Component({
  selector: 'app-principal',
  standalone: true,
  imports: [NavBarComponent, FooterComponent, ViewProductosComponent, PromocionesComponent],
  templateUrl: './principal.component.html',
  styleUrl: './principal.component.css'
})
export class PrincipalComponent {

}
