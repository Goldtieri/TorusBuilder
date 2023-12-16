using System;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing;


namespace TorusBuilder
{
    internal class ObjectGraph
    {
        public int angleX;   // Угол взгляда на 3D-модель по X 
        public int angleY;   // Угол взгляда на 3D-модель по Y
        public int angleZ;   // Угол взгляда на 3D-модель по Z
        public double zoom = 1;
        public bool GridMode;
        public double inner_radius, outer_radius;
        public int num_sides, num_rings,  red_bc = 255, green_bc = 255, blue_bc = 255, red_mc = 1, green_mc = 1, blue_mc = 1;
        public bool isComposition = false, lighting = true;
        public double X_axis = 0, Y_axis = 0, Z_axis = -40;
        public int os_x = 1, os_y = 0, os_z = 0;
        public int composition_direction = 1;
        SimpleOpenGlControl openGlControl; // Канва для рисования 3D-модели

        public ObjectGraph(SimpleOpenGlControl openGlControl)
        {
            this.openGlControl = openGlControl;
            Init();
        }

        public void Init()
        {
            // Инициализация библиотеки glut
            Glut.glutInit();
            // Инициализация режима экрана
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            // Установка цвета очистки экрана
            Gl.glClearColor(red_bc, green_bc, blue_bc, 1);
            // Установка порта вывода
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);   
            // Активация проекционной матрицы
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // Очистка матрицы
            Gl.glLoadIdentity();   
            // установка перспективы
            Glu.gluPerspective(45, (float)openGlControl.Width / (float)openGlControl.Height, 0.1, 200);  
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // начальная настройка параметров openGL
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHT0);
        }

        public void Draw()
        {
            if (lighting)
                Gl.glEnable(Gl.GL_LIGHTING);
            else if (!lighting)
                Gl.glDisable(Gl.GL_LIGHTING);
            Gl.glClearColor(red_bc, green_bc, blue_bc, 1);
            // Очистка буфера цвета и буфера глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            // Очищение текущей матрицы
            Gl.glLoadIdentity();
            Gl.glColor3d(red_mc, green_mc, blue_mc);
            // помещаем состояние матрицы в стек матриц, дальнейшие трансформации затронут только визуализацию объекта
            Gl.glPushMatrix();
            // Производим перемещение
            Gl.glTranslated(X_axis, Y_axis, Z_axis);
            // Масштабировани еобъекта
            Gl.glScaled(zoom, zoom, zoom);
            Gl.glRotated(angleX, 1, 0, 0);  // Вращение вокруг X
            Gl.glRotated(angleY, 0, 1, 0);  // Вращение вокруг Y
            Gl.glRotated(angleZ, 0, 1, 1);  // Вращение вокруг Z
            // Производим перемещение
            Gl.glTranslated(X_axis, 0, 0);
            Gl.glTranslated(0, Y_axis, 0);
            if (GridMode)   // Выбор визуализации
            {
                if (isComposition)
                {
                    DrawComposition();
                    Glut.glutWireTorus(inner_radius, outer_radius, num_sides, num_rings);
                }
                else
                {
                    Gl.glColor3d(red_mc, green_mc, blue_mc);
                    Glut.glutWireTorus(inner_radius, outer_radius, num_sides, num_rings);
                }
            }
            else
            {
                if (isComposition)
                {
                    DrawComposition();
                    Glut.glutSolidTorus(inner_radius, outer_radius, num_sides, num_rings);
                }
                else
                {
                    if (!lighting)
                    {
                        Gl.glColor3d(255, 255, 255);
                        Glut.glutWireTorus(inner_radius + 0.1, outer_radius + 0.1, 10, 10);
                    }
                    Gl.glColor3d(red_mc, green_mc, blue_mc);
                    Glut.glutSolidTorus(inner_radius, outer_radius, num_sides, num_rings);
                }
            }
            // Возвращаем состояние матрицы
            Gl.glPopMatrix();
            // Завершаем рисование
            Gl.glFlush();
            openGlControl.SwapBuffers();
        }

        public void DrawComposition()
        {
            if (composition_direction == 1)
            {
                if (outer_radius > 0)
                {
                    outer_radius -= 0.02;
                }
                else if (outer_radius <= 0)
                {
                    composition_direction = 2;
                    angleX -= 90;
                    angleY -= 90;
                }
            }
            else if (composition_direction == 2)
            {
                if (outer_radius >= -10)
                {
                    outer_radius -= 0.02;
                }
                else if (outer_radius <= -10)
                {
                    composition_direction = 3;
                }
            }
            else if (composition_direction == 3)
            {
                if (outer_radius < 0)
                {
                    outer_radius += 0.02;
                }
                else if (outer_radius >= 0)
                {
                    composition_direction = 4;
                    angleX -= 90;
                    angleY -= 90;
                }
            }
            else if (composition_direction == 4)
            {
                if (outer_radius < 10)
                {
                    outer_radius += 0.02;
                }
                else if (outer_radius >= 10)
                {
                    composition_direction = 1;
                }
            }
        }
    }
}
