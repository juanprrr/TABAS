import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssbagcartComponent } from './assbagcart.component';

describe('AssbagcartComponent', () => {
  let component: AssbagcartComponent;
  let fixture: ComponentFixture<AssbagcartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssbagcartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AssbagcartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
