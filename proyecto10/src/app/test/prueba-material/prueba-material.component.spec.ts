import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PruebaMaterialComponent } from './prueba-material.component';

describe('PruebaMaterialComponent', () => {
  let component: PruebaMaterialComponent;
  let fixture: ComponentFixture<PruebaMaterialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PruebaMaterialComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PruebaMaterialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
