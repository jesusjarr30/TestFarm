import { Component } from '@angular/core';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import {MatSidenavModule} from '@angular/material/sidenav';

@Component({
  selector: 'app-prueba-material',
  standalone: true,
  imports: [MatSlideToggleModule,MatSidenavModule],
  templateUrl: './prueba-material.component.html',
  styleUrl: './prueba-material.component.css'
})
export class PruebaMaterialComponent {

}
