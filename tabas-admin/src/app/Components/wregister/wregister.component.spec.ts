import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WregisterComponent } from './wregister.component';

describe('WregisterComponent', () => {
  let component: WregisterComponent;
  let fixture: ComponentFixture<WregisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WregisterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WregisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
