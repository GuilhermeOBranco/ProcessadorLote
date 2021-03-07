import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginaAtualComponent } from './pagina-atual.component';

describe('PaginaAtualComponent', () => {
  let component: PaginaAtualComponent;
  let fixture: ComponentFixture<PaginaAtualComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaginaAtualComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaginaAtualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
