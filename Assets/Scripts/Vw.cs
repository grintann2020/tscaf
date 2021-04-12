using UnityEngine;

namespace T {

    public class Vw {

        protected delegate void _dAct();
        protected Camera _cam;
        private SCamPrj _defPrj;
        private SOrnt3 _defOrnt;

        public Vw(SCamPrj defPrj, SOrnt3 defOrnt) {
            _defPrj = defPrj;
            _defOrnt = defOrnt;
        }

        public void SetCam(Camera cam) {
            _cam = cam;
        }

        public void SetDef() {
            SetPrj(_defPrj);
            SetOrnt(_defOrnt);
        }

        public void SetPrj(SCamPrj prj) {
            _cam.orthographic = prj.OP;
            _cam.orthographicSize = prj.OPSize;
            _cam.fieldOfView = prj.FOV;
            _cam.usePhysicalProperties = prj.PhyCam;
            _cam.nearClipPlane = prj.Near;
            _cam.farClipPlane = prj.Far;
        }

        public void SetOrnt(SOrnt3 ornt) {
            _cam.transform.position = new Vector3(ornt.A.X, ornt.A.Y, ornt.A.Z);
            _cam.transform.LookAt(new Vector3(ornt.B.X, ornt.B.Y, ornt.B.Z));
        }

        // public void Enbl() {
        //    _cam.enabled = true; 
        // }

        // public void Dsbl() {
        //    _cam.enabled = false; 
        // }
    }
}