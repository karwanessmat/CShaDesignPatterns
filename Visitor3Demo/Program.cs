﻿
using Visitor3Demo._1_Visitor_Interface;
using Visitor3Demo._2_Create_Concrete_Visitors;
using Visitor3Demo._3_Define_the_Element_Interface;
using Visitor3Demo._4__Implement_Concrete_Elements;

List<IShape> shapes = new List<IShape>()
{
    new Circle(),
    new Rectangle(),
    new Line()
};


IShapeVisitor renderVisitor = new RenderVisitor();
IShapeVisitor saveVisitor  = new SaveVisitor();


foreach (var shape in shapes)
{
    shape.Accept(renderVisitor);
    shape.Accept(saveVisitor);
}